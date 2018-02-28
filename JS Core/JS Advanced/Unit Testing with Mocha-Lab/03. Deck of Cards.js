function printCards(deck) {
    function makeCard(face,suit) {
        let validFaces = ['2','3','4','5','6','7','8','9','10','J','Q','K','A'];
        let validSuits = ['S','H','D','C'];

        if(!validFaces.includes(face) || !validSuits.includes(suit)){
            throw new Error("Invalid input data!");
        }

        let literals = {
            S:'\u2660',
            H:'\u2665',
            D:'\u2666',
            C:'\u2663'
        };

        let card = {
            face: face,
            suit: suit,
            toString: function () {
                return this.face+literals[this.suit];
            }
        };

        return card;
    }

    let cards = [];

    for (let card of deck) {
        card = card.split('');
        let suit = card.pop();
        let face = card.join('');

        try {
            cards.push((''+makeCard(face,suit)));
        }
        catch(err) {
            console.log(`Invalid card: ${face+suit}`);
            return;
        }
    }

   console.log(cards.join(' '));
}
