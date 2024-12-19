
// Az űrlap eseménykezelője
document.addEventListener('DOMContentLoaded', function () {
    // Az űrlap elem azonosítása
    const contactForm = document.getElementById('contactForm');
    const feedbackMessage = document.getElementById('feedbackMessage');

    // Eseménykezelő hozzáadása az űrlaphoz
    contactForm.addEventListener('submit', function (event) {
        // Alapértelmezett űrlapküldés megakadályozása
        event.preventDefault();

        // Üzenet megjelenítése
        feedbackMessage.style.display = 'block';

        // Az űrlap mezőinek törlése
        contactForm.reset();

        // Üzenet eltüntetése 5 másodperc múlva
        setTimeout(function () {
            feedbackMessage.style.display = 'none';
        }, 5000);
    });
});
