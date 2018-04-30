using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
  public class GameOfLifeModel
  {
    public bool[,] RunGeneration(bool[,] lifeGrid)
    {
      var rowCount = lifeGrid.GetLength(0);
      var colCount = lifeGrid.GetLength(1);
      var nextGeneration = new bool[rowCount,colCount];
      
      for (var row = 0; row < lifeGrid.GetLength(0); row++)
      {
        for (var col = 0; col < lifeGrid.GetLength(1); col++)
        {
          var neighbors = GetNeighbors(lifeGrid, row, col);
          nextGeneration[row, col] = GetNextCellValue(lifeGrid[row, col],neighbors);
        }
      }

      return nextGeneration;
    }

    private List<bool> GetNeighbors(bool[,] lifeGrid, int row, int column)
    {
      var neighbors = new List<bool>();
      if (lifeGrid.GetLength(0) <= 0) return neighbors;
      for (var x = Math.Max(0, row - 1); x <= Math.Min(row + 1, lifeGrid.GetLength(0) - 1); x++)
      {
        for (var y = Math.Max(0, column - 1); y <= Math.Min(column + 1, lifeGrid.GetLength(1) - 1); y++)
        {
          if (x == row && y == column) continue;
          neighbors.Add(lifeGrid[x,y]);
        }
      }

      return neighbors;
    }

    private static bool GetNextCellValue(bool cellHasLife, List<bool> neighbors)
    {
      var livingNeighborCount = neighbors.Count(x => x.Equals(true));
      if (cellHasLife &&  livingNeighborCount < 2) return false;
      if (cellHasLife && livingNeighborCount > 3) return false;
      if (!cellHasLife && livingNeighborCount == 3) return true;
      return cellHasLife;
    }
  }
}
