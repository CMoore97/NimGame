﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim.Models
{
    public class Board
    {
        private int totalPieces;

        public int TotalPieces
        {
            get { return totalPieces; }
            set { totalPieces = value; }
        }

        private Piece[,] boardState;

        public Piece[,] BoardState
        {
            get { return boardState; }
            set { boardState = value; }
        }

        public bool TakeAwayPiece(int row,int col)
        {
            bool didWin = false;
            if(BoardState[row, col].IsRemoved == false)
            {
                BoardState[row, col].IsRemoved = true;
                totalPieces--;
                if(totalPieces == 0)
                {
                    didWin = true;
                }
            }
            return didWin;
        }
    }

}