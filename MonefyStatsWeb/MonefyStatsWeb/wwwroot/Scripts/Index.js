function Index(parentDom) {

    this.parentDom = parentDom;
    var self = this;

    this.RenderChart = function () {
        $.getJSON("http://localhost:62347/api/profiles/3aa05f8e-a376-4813-9938-c0525ed60fd0/charts/line/", function (json) {

            var ctx = self.parentDom;
            var chart = new Chart(ctx, json);
        });
    };

    this.RenderFileLoader = function () {


    };
};
