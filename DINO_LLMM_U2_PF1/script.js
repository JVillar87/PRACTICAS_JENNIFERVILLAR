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

function Update() {
  MoveFloor();
  MoveDino();

  velY -= gravedad * deltaTime;

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