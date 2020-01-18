using System;
using System.Drawing;
using System.Windows.Forms;
using GTA;

namespace Quicksave {
   public class Quicksave : Script {

      public Quicksave() {
          this.KeyDown += new GTA.KeyEventHandler(this.Quicksave_KeyDown);
      }

      private void Quicksave_KeyDown(object sender, GTA.KeyEventArgs e)
      {
          if (e.Key == Settings.GetValueKey("Key", Keys.F5))
          {
              Game.DoAutoSave();
          }


          if (e.Key == Settings.GetValueKey("Key", Keys.F5) && e.Alt)
          {
              Game.ShowSaveMenu();
          }
      }

   }

}