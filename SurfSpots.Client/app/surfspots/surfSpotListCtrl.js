(function () {
    "use strict";

    angular
        .module("surfSpotApp")
        .controller("surfSpotListCtrl", ["surfSpotResource", surfSpotListCtrl]);

    function surfSpotListCtrl(surfSpotResource) {
        var vm = this;

        vm.searchProperty = "Location";
        vm.searchCriteria = "a";
        vm.sortProperty = "Name";
        vm.sortDirection = "asc";

        surfSpotResource.query({
            $filter: "contains("+ vm.searchProperty +", '"+ vm.searchCriteria  +"')",
            $orderby: vm.sortProperty + " " + vm.sortDirection
        },
            function (data) {
            vm.surfSpots = data;
        });
    }

}());
