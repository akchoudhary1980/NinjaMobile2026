window.TrackMarquee = function (selector, cardCount, dotnetRef, methodName) {     

    const el = document.querySelector(selector);
    if (!el) return;

    // Each card wrapper width (your container is 840px + margins)
    const cardWidth = el.children[0].offsetWidth;

    // Total width of ONLY actual cards (not duplicated ones)
    const fullWidth = cardWidth * cardCount;

    let lastIndex = -1;

    function update() {

        // Read the current transform of animated element
        const style = window.getComputedStyle(el);
        const matrix = style.transform;

        let x = 0;
        if (matrix !== "none") {
            const values = matrix.match(/matrix.*\((.+)\)/)[1].split(',');
            x = parseFloat(values[4]); // translateX
        }

        // We need positive distance, so flip sign
        const moved = Math.abs(x);

        // Wrap within original card width
        const relative = moved % fullWidth;

        // Find which card is currently left/visible
        const index = Math.floor(relative / cardWidth);

        if (index !== lastIndex) {
            lastIndex = index;
            dotnetRef.invokeMethodAsync(methodName, index);
        }

        requestAnimationFrame(update);
    }

    update();
};
