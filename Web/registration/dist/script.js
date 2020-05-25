function signIn(){
  
  var name=document.getElementById('input-name').value;
  var surname=document.getElementById('input-surname').value;
  var email=document.getElementById('input-email').value;
  var password=document.getElementById('input-password').value;
  var repass=document.getElementById('input-repassword').value;
  
  var error = document.getElementById('error');
      error.textContent=' ';
 
  if(name==""){
    return error.textContent='Введите имя';
  }
  if(surname==""){
    return error.textContent='Введите фамилию';
  }
  if(email==""){
    return error.textContent='Введите Email';
  } 
  if(password==""){
    return error.textContent='Введите Пароль';
  }  
  if(password.length!=0 && password.length<4){
     return error.textContent='Ваш пароль слишком короткий';
   }
  var r=/[^A-Z-a-z-0-9]/g; 
  if(r.test(password))return error.textContent=' Введены недопустимые символы. Разрешены латинские буквы и цифры';
   if(repass!=password){
     return error.textContent='Пароли не совпадают';
   }
  
  
  var form ={
      name:'',
      surname:'',
      email:'',
      password:''
    }
    
  form.name=name;
  form.surname=surname;
  form.email=email;
  form.password=password;
   
  
  function result(input){
    var lu = document.getElementById('list')
    var li = document.createElement('LI');
    var listText =document.createElement("p");
    var Text=document.createTextNode(input);
    
    listText.appendChild(Text);
    li.appendChild(listText);
    lu.appendChild(li);
  }
  
  result(form.name);
  result(form.surname);
  result(form.email);
  result(form.password);
  
}