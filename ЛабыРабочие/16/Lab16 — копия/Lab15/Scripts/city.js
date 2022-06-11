var apiBaseUrl = "http://localhost:51390/api/";
var countriesUrl = apiBaseUrl + "citiy/";

function reloadContinentList() {
	var countriesList = $("#citiesList");
	if (countriesList.length) {
		$.ajax({
			url: countriesUrl,
			dataType: "json",
			data: null,
			type: "GET",
			success: function (data) {
				// Do something with the result
				var itemsCount = data.length;
				countriesList.html("");
				var html = "<table>";

				for (var i = 0; i < itemsCount; i++) {
					var item = data[i];
					var countryId = item.id;
					var name = item.name;
					html += "<tr><td>" + name + "</td>";
					html += "<td><a href='edit.html?id=" + countryId + "'>Редактировать</a>&nbsp;<a href='#' class='delete_country' data-id='" + countryId + "'>Удалить</a></td></tr>";
				}

				html += "</table>";
				countriesList.html(html);
			}
		});
	}
}

$(function () {
	reloadContinentList();

	var citiInfo = $("#citiInfo");

	if (citiInfo.length) {
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");

		if (id != null) {
			$.ajax({
				url: countriesUrl + id + "/",
				dataType: "json",
				data: null,
				type: "GET",
				success: function (data) {
					var countryId = data.id;
					var name = data.name;
					var id_continent = data.id_continent;
					$("#Name").val(name);
					$("#Continent").val(id_continent);
				}
			});

			citiInfo.after("<input type='button' id='EditCity' value='Сохранить'/>");
		}
		else {
			citiInfo.after("<input type='button' id='CreateCity' value='Создать'/>");
		}
	};

	$(document).on("click", "a.delete_city", function () {
		var id = $(this).attr("data-id");

		if (id != null) {
			$.ajax({
				url: countriesUrl + id + "/",
				dataType: "json",
				data: null,
				type: "DELETE",
				success: function (data) {
					reloadContinentList();
				}
			});
		}
	});

	$(document).on("click", "#CreateCity", function () {
		var countryData = {
			name: $("#Name").val(),
			id_continent: $("#Continent").val(),
		
		};

		$.ajax({
			url: countriesUrl,
			dataType: "json",
			data: countryData,
			type: "POST",
			success: function () {
				window.location.href = "../City/index.html";
			}
		});
	});

	$(document).on("click", "#EditCity", function () {
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");

		if (id != null) {
			var countryData = {
				id: id,
				name: $("#Name").val(),
				id_continent: $("#Continent").val()
			};

			$.ajax({
				url: countriesUrl + id + "/",
				dataType: "json",
				data: countryData,
				type: "PUT",
				success: function () {
					window.location.href = "../City/index.html";
				}
			});
		}
	});
})
