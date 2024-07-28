namespace auto_Bot_999;
using ChessChallenge.API;
using System;
using System.Collections.Generic;

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
			return legalMoves[0];
		}
		
		legalMoves = board.GetLegalMoves();
		
		return legalMoves[0];
	}
}
