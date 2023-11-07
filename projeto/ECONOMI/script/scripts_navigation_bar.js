function abrirNav(){
    document.getElementById("menuOculto").style.width="30%";
    document.getElementById("principal").style.marginLeft="30%";
}
function fecharNav(){
    document.getElementById("menuOculto").style.width="0";
    document.getElementById("principal").style.marginLeft="0";
}

var AbrireFechar = 0;

function geral(){
if(AbrireFechar == 0){
    abrirNav()
    AbrireFechar = 1;
    
}
else {
    fecharNav();
    AbrireFechar = 0
}






}
