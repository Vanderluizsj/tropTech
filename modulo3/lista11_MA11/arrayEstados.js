var estados = ['Acre'
,'Alagoas'	
,'Amapá'
,'Amazonas'	
,'Bahia'	
,'Ceara'	
,'Distrito Federal' 
,'Espírito Santo'
,'Goiás'
,'Maranhão'
,'Mato Grosso'
,'Mato Grosso do Sul'
,'Minas Gerais'	
,'Pará'
,'Paraíba'
,'Paraná'
,'Pernambuco'	
,'Piauí'	
,'Rio de Janeiro'
,'Rio Grande do Norte'
,'Rio Grande do Sul'	
,'Rondônia'	
,'Roraima'
,'Santa Catarina'
,'São Paulo'
,'Sergipe'
,'Tocantins'];

var maior = ''; 
var menor = 'abcdefghijklmnopqrstuvwxyz'; 

 for (var i = 0; i < estados.length; i++) { 
    if (estados[i].length > maior.length) { 
        maior = estados[i]; 
    } 
    
    if (estados[i].length < menor.length) { 
        menor = estados[i]; 
    } 
 } 

 console.log(maior);
 console.log(menor);