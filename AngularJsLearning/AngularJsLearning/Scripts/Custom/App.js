/// <reference path="../jquery-2.1.1-vsdoc.js" />
/// <reference path="angular.js" />
(function () {
  var gems = [
    { name: 'Azurite',
      price: 2,
      description: 'Azurite solution to your problem',
      canPurchase: true,
      soldOut: false,
      image: '/Images/custom/speaker109.png'
    },
    {
      name: 'PLQuite',
      price: 5.95,
      description:'PLQuite solution to your problem',
      canPurchase: true,
      soldOut: false,
      image: '/Images/custom/alarm48.png'
    }
  ];
  
  //create a module that will encapsulate the application data
  var app = angular.module('gemStore', []);

  app.controller('StoreController', function () {
    this.products = gems;
  });

})();


/*

NB: 

-To format data we can use FILTERS
-in order to 
 
*/

  


