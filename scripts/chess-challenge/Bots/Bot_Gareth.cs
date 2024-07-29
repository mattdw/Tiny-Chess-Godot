namespace auto_Bot_999;
using ChessChallenge.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;

/* < THE GARETH BOT >
 *
 * This is pretty simple for now but before long it will definitely
 * be better at chess than Matt.
 */

public class Bot_999 : IChessBot
{
	Random random = new Random();
	ulong opponentBitboardOld = 0b0;
	bool isWhite;
	
	public Move Think(Board board, Timer timer)
	{
		
		Move[] legalMoves = board.GetLegalMoves(true);

		if(legalMoves.Length > 0) {
			var move = legalMoves[0];
			var piece = board.GetPiece(move.TargetSquare);
			
			Array.Sort(legalMoves, (moveA, moveB) => {
				var pieceA = board.GetPiece(moveA.TargetSquare);
				var pieceB = board.GetPiece(moveB.TargetSquare);
				if(pieceA.PieceType < pieceB.PieceType) {
					return 1;
				} else if (pieceA.PieceType > pieceB.PieceType) {
					return -1;
				} else {
					return 0;
				}
			});
			Debug.Print(piece.ToString());
			return legalMoves[0];
		}
		
		legalMoves = board.GetLegalMoves();
		
		return legalMoves[0];
		
		int Eval(Board board)
		{
			// Try to control more squares than the opponent
			legalMoves = board.GetLegalMoves();
			var myMoves = legalMoves.Length;
			
			var enemyMoves = 0;
			for(var square = 1; square <= 64; square++)
			{
				if (board.SquareIsAttackedByOpponent(square)) {
					enemyMoves ++;
				}
			}
		}
	}
}
