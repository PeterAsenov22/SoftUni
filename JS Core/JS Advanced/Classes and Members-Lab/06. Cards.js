let result = (function() {
    const Suits = {
        CLUBS: "\u2663", // ♣
        DIAMONDS: "\u2666", // ♦
        HEARTS: "\u2665", // ♥
        SPADES: "\u2660" // ♠
    };

    const Faces = ['2', '3', '4', '5', '6', '7', '8',
        '9', '10', 'J', 'Q', 'K', 'A'];

    class Card {
        constructor(face,suit){
            this.face = face;
            this.suit = suit;
        }

        get face(){
            return this._face;
        }

        set face(face){
            if(!Faces.includes(face)){
                throw new Error("Invalid face!")
            }

            this._face = face;
        }

        get suit(){
            return this._suit;
        }

        set suit(suit){
            if(!Object.keys(Suits).map(k=>Suits[k]).includes(suit)){
                throw new Error("Invalid suit!");
            }

            this._suit = suit;
        }

        toString(){
            return this._face + this._suit;
        }
    }

    return { Suits, Card }
})();

const Card = result.Card;
const Suits = result.Suits;

let card = new Card('2', Suits.DIAMONDS);
console.log(card.toString());
