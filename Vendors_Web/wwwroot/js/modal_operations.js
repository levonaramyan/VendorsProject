$(document).on('change', '#CountryId', function () {
    let selectElem = $("#CityId");
    selectElem.empty();
    let opt = new Option('Select', '', true, true);
    opt.disabled = true;
    selectElem.append(opt);
    console.log(this.value);
    $.ajax({
        url: urlObj.GetCitiesUrl + "/" + this.value,
        success: function (result) {
            console.log(result);
            RefreshCities(result);
        }
    });
});

function RefreshCities(cities) {
    let selectElem = $("#CityId");
    //selectElem.empty();
    //selectElem.append(new Option('Select', '', true));
    console.log("Cities are empty!!!");
    for (let i = 0; i < cities.length; i++) {
        console.log(i + "th is started");
        selectElem.append(new Option(cities[i].name, cities[i].id));        
    }
}