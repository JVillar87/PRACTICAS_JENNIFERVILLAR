var time = new Date();
var deltaTime = 0;

var floorY = 22;
var velY = 0;
var impulso = 900;
var gravedad = 2500;

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

if (document.readyState === "complete" || document.readyState === "interactive") {
  setTimeout(Init,1);  
}else{
  document.addEventListener("DOMContentLoaded", Init);
}

function Update() {
  MoveFloor();
  MoveDino();
  AñadirObstaculos();
  MoverObstaculos();

  velY -= gravedad * deltaTime;

}

function Init() {
  time = new Date();
  Start();
  Loop();
}

function Loop() {
  deltaTime = (new Date() - time) / 1000;
  time = new Date();
  Update()
  requestAnimationFrame(Loop);
}

function Start() {
  gameOver = document.querySelector(".game-over");
  floor = document.querySelector("#floor");
  container = document.querySelector("#game-container");
  textScore = document.querySelector("#score");
  dino = document.querySelector("#dino");
  cactus = document.querySelector("#cactus");

  document.addEventListener("keydown", HandleKeyDown);
}

function HandleKeyDown(){
  if (eval.keyCode == 32) {
    Saltar();
  }
}

function Saltar(){
  if (dinoPosY === floorY){
    jumping = true;
    velY = impulso;
    dino.classList.remove("dino-running");
  }
}

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

function MoverObstaculos(){
  for (var i = obstaculos.length -1; i >= 0; i--) {
    if(obstaculos[i].posX < -obstaculos[i].clientWidth){
      obstaculos[i].parentNode.removeChild(obstaculos[i]);
      obstaculos.splice(i, 1);
      GanarPuntos();
    } else{
      obstaculos[i].posX -= CalcularDesplazamiento();
      obstaculos[i].style.left = obstaculos[i].posX+"px";

    }
  }
    
  }

function GanarPuntos(){
  score++;
  textScore.innerHTML = score
}

function DetectarColision(){
  for(var i = 0; i < obstaculos.length; i++){
    if (obstaculos[i].posX > dinoPosX + dino.clientWidth) {
      break;
    }else {
      if(IsCollision()){
        gameOver();
      }
    }
  }
}

function IsCollision (a,b paddingTop, paddingRight, paddingBottom, paddingLeft){
  var aRect = a.getBoundingClientRect();
  var bRect = b.getBoundingClientRect();

  return !(
    ((aRect.top + aRect.height - paddingBottom) < (bRect.top)) ||
    (aRect.top + paddingTop > (bRect.top + bRect.height)) ||
    ((aRect.left + aRect.width - paddingRight) > bRect.left) ||
    (aRect.left + paddingLeft > (bRect.left + bRect.width))
  );
}

function GameOver() {
  Estrellarse(); 
  gameOver.style.display = "block";
}

function Estrellarse() {
  dino.classList.remove("dino-running");
  dino.classList.add("dino-crashed");
  parado = true;
}