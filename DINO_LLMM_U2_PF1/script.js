const player = document.getElementById("player")

player.addEventListener("click", ()=> {
    player.classList.add("playerJump");
} )

player.addEventListener('animationend', () => {
  player.classList.remove("playerJump");  
})
