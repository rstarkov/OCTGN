﻿/* 
 * This file was automatically generated by MyGeneration! (from BinarySender.zeus)
 * Do not modify, changes will get lost when the file is regenerated!
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Windows.Media;
using Octgn.Play;

namespace Octgn.Networking
{
	public abstract class BaseBinaryStub : IServerCalls
	{			
		protected abstract void Send(byte[] data);

		public void Binary()
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)0);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Error(string msg)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)1);
			writer.Write(msg);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Hello(string nick, ulong pkey, string client, Version clientVer, Version octgnVer, Guid gameId, Version gameVersion)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)2);
			writer.Write(nick);
			writer.Write(pkey);
			writer.Write(client);
			writer.Write(clientVer.ToString());
			writer.Write(octgnVer.ToString());
			writer.Write(gameId.ToByteArray());
			writer.Write(gameVersion.ToString());
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Settings(bool twoSidedTable)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)4);
			writer.Write(twoSidedTable);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void PlayerSettings(Player playerId, bool invertedTable)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)5);
			writer.Write(playerId.Id);
			writer.Write(invertedTable);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void NickReq(string nick)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)8);
			writer.Write(nick);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Start()
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)10);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void ResetReq()
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)11);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void NextTurn(Player nextPlayer)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)13);
			writer.Write(nextPlayer.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void StopTurnReq(int turnNumber, bool stop)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)14);
			writer.Write(turnNumber);
			writer.Write(stop);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void ChatReq(string text)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)16);
			writer.Write(text);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void PrintReq(string text)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)18);
			writer.Write(text);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void RandomReq(int id, int min, int max)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)20);
			writer.Write(id);
			writer.Write(min);
			writer.Write(max);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void RandomAnswer1Req(int id, ulong value)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)22);
			writer.Write(id);
			writer.Write(value);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void RandomAnswer2Req(int id, ulong value)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)24);
			writer.Write(id);
			writer.Write(value);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void CounterReq(Counter counter, int value)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)26);
			writer.Write(counter.Id);
			writer.Write(value);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void LoadDeck(int[] id, ulong[] type, Group[] group)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)28);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Write((short)group.Length);
			foreach (Group p in group)
				writer.Write(p.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void CreateCard(int[] id, ulong[] type, Group group)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)29);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Write(group.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void CreateCardAt(int[] id, ulong[] key, Guid[] modelId, int[] x, int[] y, bool faceUp, bool persist)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)30);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)key.Length);
						foreach (ulong p in key)
							writer.Write(p);
			writer.Write((short)modelId.Length);
			foreach (Guid g in modelId)
				writer.Write(g.ToByteArray());
			writer.Write((short)x.Length);
			foreach (int p in x)
				writer.Write(p);
			writer.Write((short)y.Length);
			foreach (int p in y)
				writer.Write(p);
			writer.Write(faceUp);
			writer.Write(persist);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void CreateAlias(int[] id, ulong[] type)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)31);
			writer.Write((short)id.Length);
			foreach (int p in id)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void MoveCardReq(Card card, Group group, int idx, bool faceUp)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)32);
			writer.Write(card.Id);
			writer.Write(group.Id);
			writer.Write(idx);
			writer.Write(faceUp);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void MoveCardAtReq(Card card, int x, int y, int idx, bool faceUp)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)34);
			writer.Write(card.Id);
			writer.Write(x);
			writer.Write(y);
			writer.Write(idx);
			writer.Write(faceUp);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Reveal(Card card, ulong revealed, Guid guid)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)36);
			writer.Write(card.Id);
			writer.Write(revealed);
			writer.Write(guid.ToByteArray());
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void RevealToReq(Player sendTo, Player[] revealTo, Card card, ulong[] encrypted)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)37);
			writer.Write(sendTo.Id);
			writer.Write((short)revealTo.Length);
			foreach (Player p in revealTo)
				writer.Write(p.Id);
			writer.Write(card.Id);
			writer.Write((short)encrypted.Length);
						foreach (ulong p in encrypted)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void PeekReq(Card card)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)39);
			writer.Write(card.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void UntargetReq(Card card)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)41);
			writer.Write(card.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void TargetReq(Card card)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)43);
			writer.Write(card.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void TargetArrowReq(Card card, Card otherCard)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)45);
			writer.Write(card.Id);
			writer.Write(otherCard.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Highlight(Card card, Color? color)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)47);
			writer.Write(card.Id);
			writer.Write(color == null ? "" : color.ToString());
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void TurnReq(Card card, bool up)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)48);
			writer.Write(card.Id);
			writer.Write(up);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void RotateReq(Card card, CardOrientation rot)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)50);
			writer.Write(card.Id);
			writer.Write((byte)rot);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Shuffle(Group group, int[] card)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)52);
			writer.Write(group.Id);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Shuffled(Group group, int[] card, short[] pos)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)53);
			writer.Write(group.Id);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Write((short)pos.Length);
			foreach (short p in pos)
				writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void UnaliasGrp(Group group)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)54);
			writer.Write(group.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Unalias(int[] card, ulong[] type)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)55);
			writer.Write((short)card.Length);
			foreach (int p in card)
				writer.Write(p);
			writer.Write((short)type.Length);
						foreach (ulong p in type)
							writer.Write(p);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void AddMarkerReq(Card card, Guid id, string name, ushort count)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)56);
			writer.Write(card.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void RemoveMarkerReq(Card card, Guid id, string name, ushort count)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)58);
			writer.Write(card.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void SetMarkerReq(Card card, Guid id, string name, ushort count)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)60);
			writer.Write(card.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void TransferMarkerReq(Card from, Card to, Guid id, string name, ushort count)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)62);
			writer.Write(from.Id);
			writer.Write(to.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void PassToReq(ControllableObject id, Player to, bool requested)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)64);
			writer.Write(id.Id);
			writer.Write(to.Id);
			writer.Write(requested);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void TakeFromReq(ControllableObject id, Player from)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)66);
			writer.Write(id.Id);
			writer.Write(from.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void DontTakeReq(ControllableObject id, Player to)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)68);
			writer.Write(id.Id);
			writer.Write(to.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void FreezeCardsVisibility(Group group)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)70);
			writer.Write(group.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void GroupVisReq(Group group, bool defined, bool visible)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)71);
			writer.Write(group.Id);
			writer.Write(defined);
			writer.Write(visible);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void GroupVisAddReq(Group group, Player who)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)73);
			writer.Write(group.Id);
			writer.Write(who.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void GroupVisRemoveReq(Group group, Player who)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)75);
			writer.Write(group.Id);
			writer.Write(who.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void LookAtReq(int uid, Group group, bool look)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)77);
			writer.Write(uid);
			writer.Write(group.Id);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void LookAtTopReq(int uid, Group group, int count, bool look)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)79);
			writer.Write(uid);
			writer.Write(group.Id);
			writer.Write(count);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void LookAtBottomReq(int uid, Group group, int count, bool look)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)81);
			writer.Write(uid);
			writer.Write(group.Id);
			writer.Write(count);
			writer.Write(look);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void StartLimitedReq(Guid[] packs)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)83);
			writer.Write((short)packs.Length);
			foreach (Guid g in packs)
				writer.Write(g.ToByteArray());
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void CancelLimitedReq()
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)85);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void IsAlternateImage(Card card, bool isAlternateImage)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)87);
			writer.Write(card.Id);
			writer.Write(isAlternateImage);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void PlayerSetGlobalVariable(Player player, string name, string val)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)88);
			writer.Write(player.Id);
			writer.Write(name);
			writer.Write(val);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void SetGlobalVariable(string name, string val)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)89);
			writer.Write(name);
			writer.Write(val);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void SwitchWithAlternate(Card card)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)90);
			writer.Write(card.Id);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void IsTableBackgroundFlipped(bool isFlipped)
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)91);
			writer.Write(isFlipped);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

		public void Ping()
		{
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)92);
			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}
	}
	
	public class BinarySenderStub : BaseBinaryStub
	{
		private TcpClient to;
		
		public BinarySenderStub(TcpClient to)
		{ this.to = to; }
		
		protected override void Send(byte[] data)
		{
			try
			{
				Stream stream = to.GetStream();
				stream.Write(data, 0, data.Length); stream.Flush();
			}
			catch 
			{ 
				Program.Client.Disconnected();
			}
		}
	}
}
