using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    abstract class Planet
    {
        /// <summary>
        ///     <Author></Author>
        ///     <StudentID></StudentID>
        ///     <DateModified></DateModified>
        ///     <Decription></Decription>
        ///     <RevisionHistory></RevisionHistory>
        /// </summary>


        //Private Instance Variables
        //-----------------------------------
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;


        //Public Properties
        //-----------------------------------
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }

        
        //Constructor
        //-----------------------------------------
        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }


        //Public Methods
        //--------------------------------------------
        public override string ToString()
        {
            return "\n--------------------------\nName: \t\t"+_name + "\nDiameter: \t" + _diameter + "\nMass: \t\t" + _mass+ "\n--------------------------";
        }
    }
}
