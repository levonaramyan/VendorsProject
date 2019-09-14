$(document).on('change', '#CountryId', function () {
    let selectElem = $("#City");
    selectElem.empty();
    let opt = new Option('Select', '', true, true);
    opt.disabled = true;
    selectElem.append(opt);
    console.log($('#CountryId').val());
    $.ajax({
        url: urlObj.GetCitiesUrl + "/" + $('#CountryId').val(),
        success: function (result) {
            console.log(result);
            RefreshCities(result);
        }
    });
});

function RefreshCities(cities) {
    let selectElem = $("#City");
    //selectElem.empty();
    //selectElem.append(new Option('Select', '', true));
    for (let i = 0; i < cities.length; i++) {
        console.log(i + "th is started");
        selectElem.append(new Option(cities[i].name, cities[i].id));        
    }
}