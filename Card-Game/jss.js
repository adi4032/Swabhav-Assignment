
let randomNum = Math.floor(Math.random() * 40);
console.log("Random Number: " + randomNum);

let attemptCount = 0;   
let maxAttempts = 7;         
let totalCards = 40;         

function createCards(numCards) {
    const cardContainer = document.getElementById("card-container");
    for (let i = 1; i <= numCards; i++) {
        const card = document.createElement("div");
        card.className = "card mx-2 my-2 d-flex justify-content-center align-items-center";
        card.style.width = "8rem";
        card.style.height = "8rem";
        card.style.borderRadius = "50%"; 
        card.style.border = "1px solid #ccc"; 
        card.style.textAlign = "center"; 
        card.style.lineHeight = "8rem"; 
        card.style.fontSize = "1.5rem"; 
        card.setAttribute("data-card-value", i); 
        cardContainer.appendChild(card);
    }
}

createCards(totalCards);
const cardElements = document.querySelectorAll("#card-container .card");

cardElements.forEach((cardElement) => {
    cardElement.addEventListener("click", (event) => {
        let selectedCardValue = parseInt(event.target.getAttribute("data-card-value")); 

        if (selectedCardValue === randomNum) {
            cardElement.style.backgroundColor = "green";
            cardElement.innerHTML = selectedCardValue; 
            alert("Congratulations! You've won the game in " + attemptCount + " attempts.");
        } else {
            attemptCount++;
            maxAttempts--;
            if (selectedCardValue < randomNum) {
                cardElement.style.backgroundColor = "skyblue";
                cardElement.style.pointerEvents = "none";
                cardElement.innerHTML = selectedCardValue; 
            } else {
                cardElement.style.backgroundColor = "red";
                cardElement.style.pointerEvents = "none";
                cardElement.innerHTML = selectedCardValue; 
            }
        }
        updateGameStats(); 
    });
});