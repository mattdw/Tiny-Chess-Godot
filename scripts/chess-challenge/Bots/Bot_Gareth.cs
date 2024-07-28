namespace auto_Bot_999;
using ChessChallenge.API;
using System;
using System.Collections.Generic;

/* < THE COPYCAT >
 *
 * This bot always tries to replicate the opponent's move as closely as possible.
 * That's it really. It's admittedly not a very good bot as far as chess bots goes
 * but that wasn't my intention. I just find it fun to look at :)
 * 
 * Thanks for everything! <3
 * 
 * - castur_
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
