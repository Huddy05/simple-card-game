using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_card_game
{
    class CCard
    {
        private int suit;
        private int value;

        public CCard() //empty constructor
        {
            suit = 0;
            value = 0;
        }
    }
    public CCard(int suit, int value) //constructor with parameters
    {
        this.suit = suit;
        this.value = value;

    }    
        

    public interface get Suit() { return suit; }
    public interface get value() { return value; }

         





}
