using CoffeeMakerLibrary;

namespace CoffeeMakerTests
{
    public class RYOContainer : IContainer
    {
        public int volume;
        public bool IsEmpty { get
            {
                if (volume == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Clean()
        {
            throw new System.NotImplementedException();
        }

        public void DispensePortion(int portion)
        {
            if (volume <= portion)
            {
                volume -= portion; 
            }
            else
            {
                throw new System.InvalidOperationException();
            }
        }

        public void Empty()
        {
            volume = 0;
        }

        public void Fill()
        {
            volume = 10;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
        }
    }
}