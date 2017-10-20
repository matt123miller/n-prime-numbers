using Xunit;
using PrimesApp;
using System;

namespace PrimesApp.Tests
{
    public class PrimesApp_GridRender
    {
        private readonly GridRender _renderer;

        public PrimesApp_GridRender()
        {
            _renderer = new GridRender();
        }


        [Fact]
        public void SmallGrid() 
        { 
            //When
            int[] values = {1,2,3,4,5};
            var knownTable = "table string";
            var result = _renderer.Render(values);
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            // Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        } 


        [Fact]
        public void MediumGrid() 
        { 
            //When
            int[] values = {1,2,3,4,5,6,7,8,9,10};
            var knownTable = "table string";
            var result = _renderer.Render(values);
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            // Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        } 

        [Fact]
        public void LargeGrid() 
        { 
            //When
            int[] values = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            var knownTable = "table string";
            var result = _renderer.Render(values);
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            // Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        } 

        // Add some tests with purposefully failing grids.
    }
}