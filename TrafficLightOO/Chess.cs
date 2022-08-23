namespace TrafficLightOO
{
    internal class Chess
    {
        /*
         * bonde = 1
         * hest = 2
         * løper = 3
         * tårn = 4
         * dronning = 5
         * konge = 6
         */
        private int[] _board = new int[]
        {
            4, 2, 3, 5, 6, 3, 2, 4, 
            1, 1, 1, 1, 1, 1, 1, 1, 
            0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0, 
            0, 0, 0, 0, 0, 0, 0, 0,
            1, 1, 1, 1, 1, 1, 1, 1,
            4, 2, 3, 5, 6, 3, 2, 4,
        };

        private Piece[] _board2 = new Piece[]
        {
            Piece.Rook, Piece.Knight, Piece.Bishop, Piece.Queen, Piece.King, Piece.Bishop, Piece.Knight, Piece.Rook,
            Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn,
            Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank,
            Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank,
            Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank,
            Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank, Piece.Blank,
            Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn, Piece.Pawn,
            Piece.Rook, Piece.Knight, Piece.Bishop, Piece.Queen, Piece.King, Piece.Bishop, Piece.Knight, Piece.Rook,
        };
    }
}
