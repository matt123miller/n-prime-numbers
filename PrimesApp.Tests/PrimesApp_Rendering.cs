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
            _renderer = GridRender();
        }


        [Theory] 
        [InlineData([2,4,6])] 
        public void SmallGrid(int[] values) 
        { 
            //When
            var result = _renderer.Render(values);
            var knownTable = "table string";
            //Then
            Console.WriteLine(values);
            // Later validate the result against a known correct table string.
            Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        } 


        [Theory] 
        [InlineData([2,4,6,8,10,12,14,16,18,20])] 
        public void MediumGrid(int[] values) 
        { 
            //When
            var result = _renderer.Render(values);
            var knownTable = "table string";
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        } 

        [Theory] 
        [InlineData([2,4,6,8,10,12,14,16,18,20])] 
        public void MediumGrid(int[] values) 
        { 
            //When
            var result = _renderer.Render(values);
            var knownTable = "table string";
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        } 
    }
}