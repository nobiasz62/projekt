
document.addEventListener('DOMContentLoaded', function () {
 
    const contactForm = document.getElementById('contactForm');
    const feedbackMessage = document.getElementById('feedbackMessage');

    contactForm.addEventListener('submit', function (event) {

        event.preventDefault();

        feedbackMessage.style.display = 'block';
        
        contactForm.reset();

        setTimeout(function () {
            feedbackMessage.style.display = 'none';
        }, 5000);
    });
});
