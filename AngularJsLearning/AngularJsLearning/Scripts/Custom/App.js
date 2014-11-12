/// <reference path="../jquery-2.1.1-vsdoc.js" />
/// <reference path="angular.js" />
(function () {
  var gems = [
              { name: 'Azurite',
                price: 2,
                description: 'Azurite solution to your problem',
                reviews: [
                  {
                    starts:5,
                    body: 'i love this products',
                    author:"joe@thomas.com"

                  },
                  {
                    starts: 2,
                    body: 'i love this products',
                    author: "thanh@thomas.com"

                  },
                  {
                    starts: 3,
                    body: 'i love this products',
                    author: "pat@thomas.com"

                  }
                ],
                specification: 'Maybe I should open a new thread for this,' +
                  ' but with this code, if I define multiple responseBoxes in the html,' +
                  ' the toggle function will affect all btn-groups to open and close. ' +
                  'I think this has something to do with scope, but I seem to fail to grasp the scope concept',
                canPurchase: true,
                soldOut: false,
                images: [
                  '/Images/custom/speaker109.png'
                ]
              },
              {
                name: 'PLQuite',
                price: 5.95,
                description: 'PLQuite solution to your problem',
                canPurchase: true,
                soldOut: false,
                reviews: [
                  {
                    starts: 5,
                    body: 'i love this products',
                    author: "joe@thomas.com"

                  },
                  {
                    starts: 2,
                    body: 'i love this products like anything else, common let rock together',
                    author: "joe@thomas.com"

                  },
                  {
                    starts: 3,
                    body: 'i love this products',
                    author: "joe@thomas.com"

                  }
                ],
                specification: 'Maybe I should open a new thread for this,' +
                  ' but with this code, if I define multiple responseBoxes in the html,' +
                  ' the toggle function will affect all btn-groups to open and close. ' +
                  'I think this has something to do with scope, but I seem to fail to grasp the scope concept',
                images: [
                '/Images/custom/alarm48.png']
              },
              {
                name: 'JanGoJanGo',
                price: 9,
                description: 'JanGoJanGo solution to your problem',
                reviews: [],
                specification: 'Maybe I should open a new thread for this,' +
                  ' but with this code, if I define multiple responseBoxes in the html,' +
                  ' the toggle function will affect all btn-groups to open and close. ' +
                  'I think this has something to do with scope, but I seem to fail to grasp the scope concept',
                canPurchase: true,
                soldOut: false,
                images: []
              }
            ];

  //create a module that will encapsulate the application data
  var app = angular.module('gemStore', []);

  //Controllers
  app.controller('StoreController', function () {
    this.products = gems;
  });

  app.controller('PanelController', function () {

    var self = this;
    self.tab = 1;
    self.selectTab = function (setTab) {

      self.tab = setTab;

    };

    self.isSelected = function (tabValue) {
      return self.tab === tabValue;
    };
  });

})();


/*

NB: 

-To format data we can use FILTERS
-in order to 
 
*/

  


