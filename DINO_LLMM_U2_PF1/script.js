const dino = document.getElementById("dino")

dino.addEventListener("click", ()=> {
    dino.classList.add("playerJump");
} )

dino.addEventListener('animationend', () => {
  dino.classList.remove("playerJump");  
})
