var time = new Date();
var deltaTime = 0;

if (document.readyState === "complete" || document.readyState === "interactive") {
  setTimeout(Init,1);  
}else{
  document.addEventListener("DOMContentLoaded", Init);
}

function Init() {
  time = new Date();
  Start();
  Loop();
}
 
function Update() {
if (parado) return;

  MoveFloor();
  MoveDino();
  AñadirObstaculos();
  MoverObstaculos();

  velY -= gravedad * deltaTime;

}

function Loop() {
  deltaTime = (new Date() - time) / 1000;
  time = new Date();
  Update()
  requestAnimationFrame(Loop);
}

var floorY = 22;
var velY = 0;
var impulso = 950;
var gravedad = 3500;

var dinoPosX = 42;
var dinoPosY = floorY;

var floorX = 0;
var velEscenario = 1280/3;
var gameVel = 1;
var score = 0;


var parado = false;
var jumping = false;

var tiempoHastaObstaculo = 2;
var tiempoObstaculoMin = 0.5;
var tiempoObstaculoMax = 1.5;
var ObstaculoPosY = 16;
var obstaculos = [];

var container;
var dino; 
var textScore;
var floor;
var gameOver;

function Start() {
  gameOver = document.querySelector(".game-over");
  floor = document.querySelector("#floor");
  container = document.querySelector("#game-container");
  textScore = document.querySelector("#score");
  dino = document.querySelector("#dino");
  cactus = document.querySelector("#cactus");

  document.addEventListener("keydown", HandleKeyDown);
}

// ACCIÓN SALTO CON BARRA ESPACIADORA (32)
function HandleKeyDown(ev){
  if (ev.keyCode == 32) { 
    Jump();
  }
}

//ACCIÓN DE SALTO
function Jump(){
  if (dinoPosY === floorY){
    jumping = true;
    velY = impulso;
    dino.classList.remove("dino-running");
  }
}

//MOVIMIENTO A LA IZQ DEL SUELO
function MoveFloor(){
  floorX += CalcularDesplazamiento();
  floor.style.left = -(floorX % container.clientWidth) + "px";
}

function MoveDino(){
  dinoPosY += velY * deltaTime;
  if(dinoPosY < floorY){
    TocarSuelo();
  }
  dino.style.bottom = dinoPosY+"px";
}

function TocarSuelo(){
  dinoPosY = floorY;
  velY = 0;
  if (jumping) {
    dino.classList.add("dino-running");
  }
  jumping = false;  
}

function CalcularDesplazamiento(){
  return velEscenario * deltaTime * gameVel;
}

function AñadirObstaculos() {
  tiempoHastaObstaculo -= deltaTime;
  if (tiempoHastaObstaculo <= 0) {
    CrearObstaculo();
  }
}

//APARICIÓN OBSTACULOS
function CrearObstaculo() {
  var obstaculo = document.createElement("div");
  container.appendChild(obstaculo);
  obstaculo.classList.add("cactus");
  obstaculo.posX = container.clientWidth;
  obstaculo.style.left = container.clientWidth+"px";

  obstaculos.push(obstaculo);
  tiempoHastaObstaculo = tiempoObstaculoMin + Math.random() * 
  (tiempoObstaculoMax-tiempoObstaculoMin) / gameVel;
}

//MOVIMIENTO DEL CACTUS
function MoverObstaculos() {
    for (var i = obstaculos.length - 1; i >= 0; i--) {
        if(obstaculos[i].posX < -obstaculos[i].clientWidth) {
            obstaculos[i].parentNode.removeChild(obstaculos[i]);
            obstaculos.splice(i, 1);
            GetPoints();
        }else{
            console.log(obstaculos[i].posX);
            obstaculos[i].posX -= CalcularDesplazamiento();
            obstaculos[i].style.left = obstaculos[i].posX+"px";
        }
    } 
}

//PUNTOS
function GetPoints(){
  score++;
  textScore.innerHTML = score
}

function GameOver() {
    Crash();
    gameOver.style.display = "block";
}

//COLISIÓN CONTRA CACTUS
function Crash() {
    dino.classList.remove("dino-corriendo");
    dino.classList.add("dino-estrellado");
    parado = true;
}

function DetectarColision() {
    for (var i = 0; i < obstaculos.length; i++) {
        if(obstaculos[i].posX > dinoPosX + dino.clientWidth) {
            break; 
        }else{
            if(IsCollision(dino, obstaculos[i], 10, 30, 15, 20)) {
                GameOver();
            }
        }
    }
}

function IsCollision(a, b, paddingTop, paddingRight, paddingBottom, paddingLeft) {
    var aRect = a.getBoundingClientRect();
    var bRect = b.getBoundingClientRect();

    return !(
        ((aRect.top + aRect.height - paddingBottom) < (bRect.top)) ||
        (aRect.top + paddingTop > (bRect.top + bRect.height)) ||
        ((aRect.left + aRect.width - paddingRight) < bRect.left) ||
        (aRect.left + paddingLeft > (bRect.left + bRect.width))
    );
}