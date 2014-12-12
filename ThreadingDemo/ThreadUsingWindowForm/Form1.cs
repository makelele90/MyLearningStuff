using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadUsingWindowForm
{
  public partial class Form1 : Form
  {
    private readonly TaskScheduler _mSyncContextTaskScheduler;
    public Form1()
    {
      _mSyncContextTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

      
      Visible = true; Width = 600; Height = 100;
      InitializeComponent();
    }

    private CancellationTokenSource _mCts;

    protected override void OnMouseClick(MouseEventArgs e)
    {
      // An operation is in flight, cancel it
      if (_mCts!=null)
      {
        _mCts.Cancel();
        _mCts = null;
      }
      else
      {
        Text = "Operation running";
        _mCts = new CancellationTokenSource();
        // This task uses the default task scheduler and executes on a thread pool thread
        var t = new Task<int>(() => Sum(_mCts.Token, 2000));


        _mCts.Cancel();
        // These tasks use the sync context task scheduler and execute on the GUI thread
        t.ContinueWith(task => Text = "Result: " + task.Result,
        CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion,
        _mSyncContextTaskScheduler);
        t.ContinueWith(task => Text = "Operation canceled",
        CancellationToken.None, TaskContinuationOptions.OnlyOnCanceled,
        _mSyncContextTaskScheduler);
        t.ContinueWith(task => Text = "Operation faulted",
        CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted,
        _mSyncContextTaskScheduler);
        
        t.Start();


      }

      base.OnMouseClick(e);
    }

    protected  int Sum(CancellationToken ct, int n)
    {
      int sum = 0;
      for (; n > 0; n--)
      {



     //   ct.ThrowIfCancellationRequested();

        if (ct.IsCancellationRequested)
        {
          return sum;
        }
        checked
        {
          sum += n;
        }

      }

      return sum;
    }
  }
}
