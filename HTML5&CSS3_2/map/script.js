var selectors = {
  map: document.getElementById("map"),
  selectCountry: document.getElementById("selectCountry"),
  flag: document.querySelector("img"),
};

var countries = [
  { name: "Egypt", lat_lang: "30.033333&31.233334" },
  { name: "Brazil", lat_lang: "-15.793889&-47.882778" },
  { name: "Japan", lat_lang: "35.652832&139.839478" },
  { name: "Italy", lat_lang: "41.902782&12.496366" },
];

//functions
function allowGetLocation(location) {
  const myLatLng = {
    lat: location.coords.latitude,
    lng: location.coords.longitude,
  };
  const map = new google.maps.Map(selectors.map, {
    zoom: 3.5,
    center: myLatLng,
  });

  new google.maps.Marker({
    position: myLatLng,
    map,
    title: "Location",
  });
}
function denayGetLocation(err) {
  selectors.map.innerHTML =
    err.code == 1
      ? "<div class='error'><h1>Allow access location</h1></div>"
      : "<div class='error'><h1>Something wrong</h1></div>";
}
/////////////////////////////////////////////////
countries.forEach(function (country) {
  var option = document.createElement("option");
  option.value = country.name + "&" + country.lat_lang;
  option.innerText = country.name;
  selectors.selectCountry.append(option);
});

window.navigator.geolocation.getCurrentPosition(
  allowGetLocation,
  denayGetLocation
);

//////////////////////////////
selectors.selectCountry.addEventListener("change", function () {
  var countryData = this.value.split("&");
  selectors.flag.src = "flags/" + countryData[0] + ".png";
  const myLatLng = {
    lat: Number(countryData[1]),
    lng: Number(countryData[2]),
  };
  const map = new google.maps.Map(selectors.map, {
    zoom: 3.5,
    center: myLatLng,
  });
  new google.maps.Marker({
    position: myLatLng,
    map,
    title: "Location",
  });
});
