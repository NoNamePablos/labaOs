// Существуют разные способы получить DOM-узел; здесь мы определяем саму форму и
// поле ввода email и элемент span, в который поместим сообщение об ошибке
const form  = document.querySelector('.form-registation');

const email = document.getElementById('email');
const emailError = document.querySelector('#mail + span.error');
const buttonEye=document.querySelector('.form-password-eye');
const text=document.querySelectorAll('input[type=text]');
const password = document.getElementById('password');

buttonEye.addEventListener('click',()=>{
   const btnPswrd= buttonEye.closest('.form-pole').querySelector('input[name=password]');
   if(btnPswrd.getAttribute('type')==='password'){
       btnPswrd.setAttribute('type', 'text');
   }else{
    btnPswrd.setAttribute('type', 'password');
   }
});

text.forEach((el)=>{
if(el.getAttribute('name')!='password'){
    el.addEventListener('input',()=>{
        console.log(el.value.length);
        if(el.value.length>0){
            el.classList.remove('form-error');
            el.closest('.form-pole').removeAttribute('data-error');
        }else{
            console.log('NULLLLL1');
            showError(el); 
        }
    });}
});

password.addEventListener('input',()=>{
    if(passwordvalidate(password.value)!=false){
        console.log('valid ',password.value);
        password.classList.remove('form-error');
        password.closest('.form-pole').removeAttribute('data-error');
    }else{
        showError(password);
    }
});
email.addEventListener('input', function (event) {
  // Каждый раз, когда пользователь что-то вводит,
  // мы проверяем, являются ли поля формы валидными

  if (email.validity.valid) {
    // Если на момент валидации какое-то сообщение об ошибке уже отображается,
    // если поле валидно, удаляем сообщение
    email.classList.remove('form-error');
    email.closest('.form-pole').removeAttribute('data-error');
  } else {
    // Если поле не валидно, показываем правильную ошибку
    showError(email);
  }
});

form.addEventListener('submit', function (event) {
  // Если поле email валдно, позволяем форме отправляться

  if(!email.validity.valid) {
    // Если поле email не валидно, отображаем соответствующее сообщение об ошибке
    showError(email);
    // Затем предотвращаем стандартное событие отправки формы
    event.preventDefault();
  }
    text.forEach((el)=>{
        if(el.value.length==0){
            showError(el);
            console.log('NULLLLL');
            event.preventDefault();
        }
    });
    if(passwordvalidate(password.value)==false){
        console.log(password);
        console.log("lolo ",passwordvalidate(password.value));
        showError(password);
        event.preventDefault();
    }

});

function showError(email) {
  if(email.getAttribute('type')=='email') {
    if(email.validity.valueMissing) {
        email.closest('.form-pole').setAttribute('data-error',"Ошибка email");
        email.classList.add('form-error');
      } else if(email.validity.typeMismatch) {
        email.closest('.form-pole').setAttribute('data-error',"Ошибка email");
        email.classList.add('form-error');
      } else if(email.validity.tooShort) {
        email.closest('.form-pole').setAttribute('data-error',"Ошибка email");
        email.classList.add('form-error');

    }
  }
  if(email.getAttribute('type')=='text'){
        console.log('tst1');
        email.closest('.form-pole').setAttribute('data-error',"Ошибка ввода ИМЯ/ФАМИЛИЯ/ОТЧЕСТВО");
        email.classList.add('form-error');     
    }

    if(email.getAttribute('type')=='password'){
        email.closest('.form-pole').setAttribute('data-error',"Ошибка ввода ПАРОЛЯ (МИНИМУМ 8 СИМВОЛОВ)");
        email.classList.add('form-error');     
    }

}

function passwordvalidate(s) {
    return /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$/gm.test(s);
}