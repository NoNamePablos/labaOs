var apiBaseUrl = "http://localhost:51390/api/";
var countriesUrl = apiBaseUrl + "Continents/";

function reloadContinentList() {
	var continetsList = $("#ContinentsList");
	if (continetsList.length) {
		$.ajax({
			url: countriesUrl,
			dataType: "json",
			data: null,
			type: "GET",
			success: function (data) {
				// Do something with the result
				var itemsCount = data.length;
				continetsList.html("");
				var html = "<table>";

				for (var i = 0; i < itemsCount; i++) {
					var item = data[i];
					var continentId = item.id;
					var name = item.name;
					html += "<tr><td>" + name + "</td>";
					html += "<td><a href='edit.html?id=" + continentId + "'>Редактировать</a>&nbsp;<a href='#' class='delete_continent' data-id='" + continentId + "'>Удалить</a></td></tr>";
				}

				html += "</table>";
				continetsList.html(html);
			}
		});
	}
}

$(function () {
	reloadContinentList();

	var continentInfo = $("#ContinentInfo");

	if (continentInfo.length) {
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
					var continentId = data.id;
					var name = data.name;
					$("#Id").val(continentId);
					$("#Name").val(name);
				}
			});

			continentInfo.after("<input type='button' id='EditContinent' value='Сохранить'/>");
		}
		else {
			continentInfo.after("<input type='button' id='CreateContinent' value='Создать'/>");
		}
	};

	$(document).on("click", "a.delete_continent", function () {
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

	$(document).on("click", "#CreateContinent", function () {
		var continentData = {
			name: $("#Name").val(),
		};

		$.ajax({
			url: countriesUrl,
			dataType: "json",
			data: continentData,
			type: "POST",
			success: function () {
				window.location.href = "../Continents/index.html";
			}
		});
	});

	$(document).on("click", "#EditContinent", function () {
		var url_string = window.location.href;
		var url = new URL(url_string);
		var id = url.searchParams.get("id");

		if (id != null) {
			var continentData = {
				id: id,
				name: $("#Name").val(),
			};

			$.ajax({
				url: countriesUrl + id + "/",
				dataType: "json",
				data: continentData,
				type: "PUT",
				success: function () {
					window.location.href = "../Continents/index.html";
				}
			});
		}
	});
})
