//переменная фильтра
const filterProperties = ["Brand", "Type","Submodel", "Switches", "Form-Factor"];
//то что видим
const displayProperties = ["Brand", "Model", "Type","Submodel", "Switches", "Form-Factor"];
//характеристики телефона
const mouseProperties = ["Brand", "Model","Submodel", "Type", "Switches", "Price", "Form-Factor"];

//создание массива телефонов
function setMouse(arr) {
    var phone = new Map(); //создание коллекции ключ-значение
    
    for (var i = 0; i < arr.length; ++i) {
        phone.set(mouseProperties[i], arr[i]); //по ключу записывает значение
    }
    
    return phone;
}

//заносим данные в массив
var DATA = [
    // iPhone 7
    setMouse(["ZOWIE", "EC","S", "Мышь", "3360", "$450", "Беспроводная"]),
    setMouse(["ZOWIE", "EC", "M","Мышь", "3360", "$450", "Проводная"]),
   
    setMouse(["HyperX", "Cloud", "M","Мышь", "3200", "$250", "Проводная"]),
    setMouse(["HyperX", "Stinger", "LX","Мышь", "3200", "$650", "Проводная"]),
    setMouse(["HyperX", "pulsfire", "FPS","Мышь", "3200", "$50", "Проводная"]),
    setMouse(["HyperX", "pulsfire", "Gaming Edition","Мышь", "3200", "$150", "Беспроводная"]),
    setMouse(["Logitech", "X", "Gaming Edition","Мышь", "2800", "$550", "Беспроводная"]),
    setMouse(["Logitech", "Core", "S","Мышь", "3232", "$250", "Беспроводная"]),
    setMouse(["Logitech", "G", "102","Мышь", "2450", "$30", "Проводная"]),
];

// вывести данные на экран
function printGoods(data) {
    if (data.length !== 0) {
        
        var phonesDiv = document.createElement("div");//создание элемента
        phonesDiv.className = "phonesDiv";
        
        var phones = document.createElement("ul"); //создание  списка
        phones.setAttribute("class", "phones");//устанавливаем атрибут =phones
        
        phonesDiv.appendChild(phones);//вставка жлементов в конец спска
        
        document.getElementsByClassName('Goods')[0].replaceChild(phonesDiv, document.getElementsByClassName('Goods')[0].firstChild);

        
        for (var i = 0; i < data.length; ++i) {
            
            var PHONE = document.createElement("li");//элемент списка
            var phone = document.createElement("div");//блок
            var brand = document.createElement("h3");
            var model = document.createElement("h4");
            
            var dispProps = new Array();//создание массива
            
            PHONE.setAttribute("class", "PHONE");
            
            phone.setAttribute("name", "phone");
            phone.setAttribute("class", "phone");

            //получаем текстовое содержимое эл-та 
            brand.innerText = data[i].get(displayProperties[0]);
            model.innerText = "model: " + data[i].get(displayProperties[1]);

            
            for (var j = 2; j < displayProperties.length; ++j) {
                
                var prop = document.createElement("p");
                prop.innerText = displayProperties[j] + ": " + data[i].get(displayProperties[j]);
                
                dispProps.push(prop);
            }

            phone.append(brand, model);//вставляем телефон в конец
            
            //обходим все элементы массива
            for (var prop of dispProps) {
                phone.append(prop); //вставляем в конец
            }
            
            PHONE.append(phone);
            phones.append(PHONE);
        }
    } else {
        var div = document.createElement("div");
        div.className = "resetFiltres";
        
        document.getElementsByClassName('Goods')[0].replaceChild(div, document.getElementsByClassName('Goods')[0].firstChild);
        
        var noElemsText = document.createElement("h3");
        noElemsText.innerText = "There is no matching items";
        
        var middleText = document.createElement("h3");
        middleText.innerText = "Try simpling your search";
        
        var button = document.createElement("input");
        button.setAttribute("Type", "button");
        button.setAttribute("value", "RESET");
        button.className = "resetButton";
        button.onclick = reset
        
        div.appendChild(noElemsText);
        div.appendChild(middleText);
        div.appendChild(button);
    }
}

printGoods(DATA);

// вернуть уникальные значения для фильтра по свойству
function getFilterValues(propetry) {
    var values = new Set();
    var aValues = new Array();
    
    for (var phone of DATA) {
        
        var key = phone.get(propetry);
        
        if (!values.has(key)) {
            values.add(key)
            aValues.push(key);
        }
    }
    return aValues;
}

var _reset = false;

// функция ресет
function reset() {
    _resetreset = true;
    
    FILTRES.forEach((fvalue, fkey, fmap) => {
        var cs = document.getElementsByName(fkey);
        var texts = document.getElementsByName("p" + fkey);
        var i = 0;
        
        fvalue.forEach((rvalue, rkey, rmap) => {
            cs[i].disabled = false;
            cs[i].checked = false;
            texts[i].className = "en";
            ++i;
            rmap.set(rkey, false);
        }); 
    });
    
    printGoods(DATA);
}

// переменная фильтров
var FILTRES = new Map();

// создание фильтра
for (var filterProperty of filterProperties) {
    var values = getFilterValues(filterProperty);
    // values = [value]
    var filterRows = new Map();
    
    for (var value of values) {
        filterRows.set(value, false);
    }
    
    FILTRES.set(filterProperty, filterRows);
}

// создание заголовка для фильтров
var title = document.createElement("h3");
title.innerText = "Переферия";
document.getElementsByClassName("filters")[0].append(title);

// вывод фильтров на экран
FILTRES.forEach((fvalue, fkey, fmap) => {
    
    var div = document.createElement("div");
    div.className = fkey;
    
    var filterBlockTitle = document.createElement("h3");
    filterBlockTitle.innerText = fkey;
    filterBlockTitle.className = "filterBlockTitle";
    
    div.appendChild(filterBlockTitle);
    
    fvalue.forEach((rvalue, rkey, rmap) => {
        var label = document.createElement("label");
        var checkbox = document.createElement("input");
        var text = document.createElement("p");
        
        text.setAttribute("name", "p" + fkey);
        text.innerText = rkey;
        
        checkbox.addEventListener("change", change);
        checkbox.value = rkey;
        checkbox.name = fkey;
        checkbox.type = "checkbox";
        
        label.setAttribute("class", "label");
        label.appendChild(checkbox);
        label.appendChild(text);

        div.appendChild(label);
    });
    
    document.getElementsByClassName("filters")[0].appendChild(div);
});

// вернет true если нет ни одной галочки
// вернет false если есть где нибудь хотя бы одна галочка
function allCheckboxesAreUnchecked() {
    var COUNT = 0;
    FILTRES.forEach((fvalue, fkey, fmap) => {
        var count = 0;
        fvalue.forEach((rvalue, rkey, rmap) => {
            if (!rvalue) {
                ++count;
            }
        });
        if (count === fvalue.size) {
            ++COUNT;
        }
    });
    if (COUNT === FILTRES.size) {
        return true;
    } else {
        return false;
    }
}

// активация всех чекбоксов
function activeAllCheckboxes() {    
    FILTRES.forEach((fvalue, fkey, fmap) => {
        var checkboxes = document.getElementsByName(fkey);
        var texts = document.getElementsByName("p" + fkey);
        
        for (var i = 0; i < fvalue.size; ++i) {
            checkboxes[i].disabled = false;
            texts[i].className = "en";
        }
    });
}

function change(e) {
    var obj = e.target;//получение доступа к э-ту который вызвал эвент
    FILTRES.get(obj.name).set(obj.value, obj.checked);
    
    if (allCheckboxesAreUnchecked()) {
        printGoods(DATA);
        activeAllCheckboxes();
    } else {
        var newData = new Array(); // newData
        var changedPropertyName = obj.name;
        
        // creating newData
        for (var data of DATA) {
            var matchFiltresCount = 0;
            
            FILTRES.forEach((strCbxs, property, fmap) => {
                var uncheckedCount = 0;
                var matchFound = false;
                
                strCbxs.forEach((checkbox, string, rmap) => {
                    if (!checkbox) {
                        ++uncheckedCount;
                    } else {
                        if (data.get(property) === string) {
                            matchFound = true;
                        }
                    }
                });
                if (uncheckedCount === strCbxs.size) {
                    ++matchFiltresCount;
                } else {
                    if (matchFound) {
                        ++matchFiltresCount;
                    }
                }
                    
            });
            
            if (matchFiltresCount === FILTRES.size) {
                newData.push(data);
            }
        }
        
        // устанавливаем фильтры кроме того, которой изменили
        FILTRES.forEach((strCbxs, property, fmap) => {
            if (property !== changedPropertyName) {
               
                var checkboxes = document.getElementsByName(property); // checkboxes
                var texts = document.getElementsByName("p" + property);
                var matchFound = false;
                var i = 0;
                // получить newData1 для текущего блока фильтров
                var nd = dataBasedOnFiltresExceptCurrent(property)
                
                strCbxs.forEach((checkbox, string, rmap) => {
                    matchFound = false;
                    for (var data of nd) { // todo
                        if (data.get(property) === string) {
                            matchFound = true;
                        }
                    }
                    if (matchFound) {
                        checkboxes[i].disabled = false;
                        texts[i].className = "en";
                    } else {
                        checkboxes[i].disabled = true;
                        texts[i].className = "dis";
                    }
                    ++i;
                });   
            }
        });
        // печать newData
        printGoods(newData);
    }
}
// вернет массив данных, который формируется по всем фильтрам, кроме того который указан в property
function dataBasedOnFiltresExceptCurrent(property) {    
    var nd = new Array();
    
    for (var data of DATA) {
        var matchFiltresCount = 0;
        
        FILTRES.forEach((strCbxs, prop, fmap) => {
            if (prop !== property) {
                var uncheckedCount = 0;
                var checkboxes = document.getElementsByName(prop);
                var i = 0;
                var matchFound = false;
                
                strCbxs.forEach((checkbox, string, rmap) => {
                    if (!checkbox) {
                        ++uncheckedCount;
                    } else {
                        if (data.get(prop) === string && !checkboxes[i].disabled) { // fixme
                            matchFound = true;
                        }
                    }
                    ++i;
                });
                
                if (uncheckedCount === strCbxs.size) {
                    ++matchFiltresCount;
                } else {
                    if (matchFound) {
                        ++matchFiltresCount;
                    }
                }
            } 
        });
        
        if (matchFiltresCount === FILTRES.size - 1) {
            nd.push(data);
        }
    }
    return nd;
}