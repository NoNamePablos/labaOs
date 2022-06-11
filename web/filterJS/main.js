const filters=document.getElementById('Filters');
const btnSbmt=document.getElementById('submit');
const container=document.querySelectorAll('.box');
console.log(filters);
let array=[];
filters.addEventListener('change',()=>{
     array=filters.querySelectorAll('input:checked');
     let locArr=array;
    array.forEach((el)=>{
        locArr=getEls(el.value);
        console.log(locArr);
    });
});

function getEls(filter){
    let locArr=[];
    container.forEach((el)=>{
        if(el.classList.contains(filter)){
            locArr.push(el);
        }else{
            el.classList.add('hide');
        }
    });
    return locArr;

}


