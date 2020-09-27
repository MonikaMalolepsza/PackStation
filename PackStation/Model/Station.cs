using System;
namespace PackStation.Model
{
    public class Station
    {

        #region Attributes

        private Box[] _boxes;
 
        #endregion

        #region Properties

        public Box[] Boxes { get => _boxes; set => _boxes = value; }

        #endregion

        #region Constructors

        //Default Constructor
        public Station()
        {
            Boxes = new Box[9];
        }

        #endregion

        #region Methods

            /**
             * TODO:
             * implement open function which iterates over all the packages and returns the one to open.
             */

        public int PackageFinder( int packageId)
        {
            return packageId;
        }

            /**
             * TODO:
             * implement open function which opens the box.
             */

        public int BoxOpener( int packageId)
        {
            return packageId;
        }
            /**
             * TODO:
             * implement close function which closes the box.
             */

        public bool BoxCloser(Package package)
        {
            return false;
        }

        #endregion

    }

}
