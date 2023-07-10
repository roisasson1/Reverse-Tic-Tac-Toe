using System;

namespace Engine
{
    internal class Board
    {
        private readonly eCellStatus[,] m_CellsBoard;
        private int m_BoardSize;
        private readonly Action<eCellStatus>[,] r_ActionMatrix;

        public Board(int i_BoardSize)
        {
            m_BoardSize = i_BoardSize;
            r_ActionMatrix = new Action<eCellStatus>[i_BoardSize, i_BoardSize];
            m_CellsBoard = new eCellStatus[i_BoardSize, i_BoardSize];
            InitializeBoard();
        }

        public int BoardSize
        {
            get { return m_BoardSize; }
            set { m_BoardSize = value; }
        }

        public void AddHandlerToActionMatrix(int i_Row, int i_Col, Action<eCellStatus> i_Method)
        {
            r_ActionMatrix[i_Row - 1, i_Col - 1] = i_Method;
        }

        public void SetCell(int i_Row, int i_Col, eCellStatus i_Value, bool i_Check)
        {
            m_CellsBoard[i_Row - 1, i_Col - 1] = i_Value;
            if (!i_Check)
            {
                r_ActionMatrix[i_Row - 1, i_Col - 1].Invoke(i_Value);
            }
        }

        public bool IsCellEmpty(int i_Row, int i_Col)
        {
            return m_CellsBoard[i_Row - 1, i_Col - 1] == eCellStatus.Empty;
        }

        public eCellStatus GetCellSymbol(int i_Row, int i_Col)
        {
            return m_CellsBoard[i_Row, i_Col];
        }

        public void ClearBoard()
        {
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    if (!IsCellEmpty(i + 1, j + 1))
                    {
                        SetCell(i + 1, j + 1, eCellStatus.Empty, false);
                    }
                }
            }
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    m_CellsBoard[i, j] = eCellStatus.Empty;
                }
            }
        }
    }
}