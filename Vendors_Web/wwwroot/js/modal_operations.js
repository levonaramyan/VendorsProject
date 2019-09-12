$(document).on('change', '#CountryId', function () {
    let selectElem = $("#CityId");
    selectElem.empty();
    let opt = new Option('Select', '', true, true);
    opt.disabled = true;
    selectElem.append(opt);
    console.log($('#CountryId').value);
    $.ajax({
        url: urlObj.GetCitiesUrl + "/" + $('#CountryId').value,
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
    for (let i = 0; i < cities.length; i++) {
        console.log(i + "th is started");
        selectElem.append(new Option(cities[i].name, cities[i].id));        
    }
}