(function () {

  var app = angular.module('store-products', []);
  
  app.directive('productDetails', function () {

    return {
      restrict: 'E', //html element directive
      templateUrl: '/Scripts/Custom/product-details.html'
    };
  });
  app.directive('productPanels', function () {

    return {
      restrict: 'E',
      templateUrl: '/Scripts/Custom/product-panels.html',
      controller: function () {
        var self = this;
        self.tab = 1;
        self.selectTab = function (setTab) {

          self.tab = setTab;

        };

        self.isSelected = function (tabValue) {
          return self.tab === tabValue;
        };
      },
      controllerAs: 'panel'
    };
  });
})();