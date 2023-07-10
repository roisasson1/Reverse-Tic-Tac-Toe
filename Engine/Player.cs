using System;

namespace Engine
{
    internal class Player
    {
        private string m_Nickname;
        private readonly eCellStatus m_Symbol;
        private int m_Score;
        private readonly bool m_IsComputer;

        internal Player(string i_PlayerNickname, eCellStatus i_PlayerSymbol, bool i_IsComputer)
        {
            m_Nickname = i_PlayerNickname;
            m_Symbol = i_PlayerSymbol;
            m_Score = 0;
            m_IsComputer = i_IsComputer;
        }

        public event Action<int> r_ScoreAction;

        public string Nickname
        {
            get { return m_Nickname; }
            set { m_Nickname = value; }
        }

        public eCellStatus GetSymbol
        {
            get { return m_Symbol; }
        }

        public int Score
        {
            get { return m_Score; }
            set { m_Score = value; }
        }

        public bool IsComputer
        {
            get { return m_IsComputer; }
        }

        public void IncrementScore()
        {
            Score++;
            OnScoreChange();
        }

        protected virtual void OnScoreChange()
        {
            r_ScoreAction.Invoke(Score);
        }
    }
}