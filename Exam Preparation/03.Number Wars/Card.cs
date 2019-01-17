using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Number_Wars
{
	class Card
	{
		//working between 70 of 100 and 90 of 100
		//const int MaxCounter = 1_000_000;

		//static void Main(string[] args)
		//{
		//	Queue<string> firstAllCards = new Queue<string>(Console.ReadLine().Split());
		//	Queue<string> secondAllCards = new Queue<string>(Console.ReadLine().Split());
		//	int turnsCounter = 0;
		//	bool gameOver = false;

		//	while (turnsCounter < MaxCounter
		//		&& firstAllCards.Count > 0
		//		&& secondAllCards.Count > 0
		//		&& !gameOver)
		//	{
		//		turnsCounter++;
		//		string firstCard = firstAllCards.Dequeue();
		//		string secondCard = secondAllCards.Dequeue();

		//		if (GetNumber(firstCard) > GetNumber(secondCard))
		//		{
		//			firstAllCards.Enqueue(firstCard);
		//			firstAllCards.Enqueue(secondCard);
		//		}
		//		else if (GetNumber(firstCard) < GetNumber(secondCard))
		//		{
		//			secondAllCards.Enqueue(secondCard);
		//			secondAllCards.Enqueue(firstCard);
		//		}
		//		else
		//		{
		//			List<string> cardsHand = new List<string> { firstCard, secondCard };

		//			while (!gameOver)
		//			{
		//				if (firstAllCards.Count >= 3 && secondAllCards.Count >= 3)
		//				{
		//					int firstSum = 0;
		//					int secondSum = 0;

		//					for (int counter = 0; counter < 3; counter++)
		//					{
		//						string firstHandCard = firstAllCards.Dequeue();
		//						string secondHandCard = secondAllCards.Dequeue();
		//						firstSum += GetChar(firstHandCard);
		//						secondSum += GetChar(secondHandCard);
		//						cardsHand.Add(firstHandCard);
		//						cardsHand.Add(secondHandCard);
		//					}

		//					if (firstSum > secondSum)
		//					{
		//						AddCardsToWinner(cardsHand, firstAllCards);
		//						break;
		//					}
		//					else if (firstSum < secondSum)
		//					{
		//						AddCardsToWinner(cardsHand, secondAllCards);
		//						break;
		//					}
		//				}
		//				else
		//				{
		//					gameOver = true;
		//				}
		//break;
		//			}
		//		}
		//	}

		//	string result = " ";

		//	if (firstAllCards.Count == secondAllCards.Count)
		//	{
		//		result = "Draw";
		//	}
		//	else if (firstAllCards.Count > secondAllCards.Count)
		//	{
		//		result = "First player wins";
		//	}
		//	else
		//	{
		//		result = "Second player wins";
		//	}

		//	Console.WriteLine($"{result} after {turnsCounter} turns");
		//}

		//private static void AddCardsToWinner(List<string> cardsHand, Queue<string> firstAllCard)
		//{
		//	foreach (string card in cardsHand.OrderByDescending(c => GetNumber(c))
		//.ThenByDescending(c => GetChar(c)))
		//	{
		//		firstAllCard.Enqueue(card);
		//	}
		//}

		//static int GetNumber(string card)
		//{
		//	return int.Parse(card.Substring(0, card.Length - 1));
		//}

		//static int GetChar(string card)
		//{
		//	return card[card.Length - 1];
		//}
		//with classes

		class StartUp
		{
			public static void Main()
			{
				string[] firstInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string[] secondInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				Queue<Card> firstPlayer = GetPlayerHand(firstInput);
				Queue<Card> secondPlayer = GetPlayerHand(secondInput);

				int turns = 0;

				while (true)
				{
					turns++;
					Card firstPlayerCard = firstPlayer.Dequeue();
					Card secondPlayerCard = secondPlayer.Dequeue();

					int firstPlayerCardNumber = firstPlayerCard.Number;
					int secondPlayerCardNumber = secondPlayerCard.Number;

					if (firstPlayerCardNumber > secondPlayerCardNumber)
					{
						firstPlayer.Enqueue(firstPlayerCard);
						firstPlayer.Enqueue(secondPlayerCard);
					}

					if (secondPlayerCardNumber > firstPlayerCardNumber)
					{
						secondPlayer.Enqueue(secondPlayerCard);
						secondPlayer.Enqueue(firstPlayerCard);
					}

					if (firstPlayerCardNumber == secondPlayerCardNumber)
					{
						List<Card> firstPlayerNextCards = new List<Card> { firstPlayerCard };
						List<Card> secondPlayerNextCards = new List<Card> { secondPlayerCard };

						while (true)
						{
							for (int i = 0; i < Math.Min(firstPlayer.Count, 3); i++)
							{
								firstPlayerNextCards.Add(firstPlayer.Dequeue());
							}

							for (int i = 0; i < Math.Min(secondPlayer.Count, 3); i++)
							{
								secondPlayerNextCards.Add(secondPlayer.Dequeue());
							}

							if (firstPlayerNextCards.Count > secondPlayerNextCards.Count)
							{
								List<Card> allCards = TakeAllCards(firstPlayerNextCards, secondPlayerNextCards);

								foreach (Card card in allCards)
								{
									firstPlayer.Enqueue(card);
								}

								break;
							}

							if (secondPlayerNextCards.Count > firstPlayerNextCards.Count)
							{
								List<Card> allCards = TakeAllCards(firstPlayerNextCards, secondPlayerNextCards);

								foreach (Card card in allCards)
								{
									secondPlayer.Enqueue(card);
								}

								break;
							}

							if (firstPlayerNextCards.Count == secondPlayerNextCards.Count)
							{
								long firstPlayerSum = CalculatePlayerSum(firstPlayerNextCards);
								long secondPlayerSum = CalculatePlayerSum(secondPlayerNextCards);

								if (firstPlayerSum > secondPlayerSum)
								{
									List<Card> allCards = TakeAllCards(firstPlayerNextCards, secondPlayerNextCards);

									foreach (Card card in allCards)
									{
										firstPlayer.Enqueue(card);
									}

									break;
								}

								if (secondPlayerSum > firstPlayerSum)
								{
									List<Card> allCards = TakeAllCards(firstPlayerNextCards, secondPlayerNextCards);

									foreach (Card card in allCards)
									{
										secondPlayer.Enqueue(card);
									}

									break;
								}
							}

							if (firstPlayer.Count == 0 && secondPlayer.Count == 0)
							{
								Console.WriteLine($"Draw after {turns} turns");
								return;
							}
						}
					}

					if (firstPlayer.Count == 0)
					{
						Console.WriteLine($"Second player wins after {turns} turns");
						break;
					}

					if (secondPlayer.Count == 0)
					{
						Console.WriteLine($"First player wins after {turns} turns");
						break;
					}

					if (turns == 1000000)
					{
						if (firstPlayer.Count > secondPlayer.Count)
						{
							Console.WriteLine($"First player wins after {turns} turns");
							break;
						}
						else if (secondPlayer.Count > firstPlayer.Count)
						{
							Console.WriteLine($"Second player wins after {turns} turns");
							break;
						}
						else
						{
							Console.WriteLine($"Draw after {turns} turns");
							break;
						}
					}
				}
			}

			private static long CalculatePlayerSum(List<Card> playerCards)
			{
				long sum = 0;

				for (int i = playerCards.Count - 3; i < playerCards.Count; i++)
				{
					sum += playerCards[i].Symbol;
				}

				return sum;
			}

			private static List<Card> TakeAllCards(List<Card> firstPlayerNextCards, List<Card> secondPlayerNextCards)
			{
				List<Card> allCards = new List<Card>();
				firstPlayerNextCards.AddRange(secondPlayerNextCards);

				foreach (Card card in firstPlayerNextCards
					.OrderByDescending(n => n.Number)
					.ThenByDescending(s => s.Symbol))
				{
					allCards.Add(card);
				}

				return allCards;
			}

			private static Queue<Card> GetPlayerHand(string[] input)
			{
				Queue<Card> playerHand = new Queue<Card>();

				foreach (string cardPart in input)
				{
					int number = int.Parse(cardPart.Substring(0, cardPart.Length - 1));
					char symbol = cardPart[cardPart.Length - 1];
					Card card = new Card(number, symbol);
					playerHand.Enqueue(card);
				}

				return playerHand;
			}
		}

		public Card(int number, char symbol)
		{
			Number = number;
			Symbol = symbol;
		}

		public int Number
		{
			get;
			set;
		}

		public char Symbol
		{
			get;
			set;
		}
	}
}
