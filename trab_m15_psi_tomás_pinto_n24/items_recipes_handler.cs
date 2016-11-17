/********************************************************************
	created:	2016/11/17
	created:	17:11:2016   17:26
	filename: 	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24\items_recipes_handler.cs
	file path:	C:\Users\legobrainiac\documents\visual studio 2015\Projects\trab_m15_psi_tomás_pinto_n24\trab_m15_psi_tomás_pinto_n24
	file base:	items_recipes_handler
	file ext:	cs
	author:		Tomás António Sanches Pinto
	
	purpose:	Handles CRUD for table "items_recipes"
*********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_m15_psi_tomás_pinto_n24
{
    //Handles CRUD for table "items_recipes"
    class items_recipes_handler
    {
        int id;
        int id_craftable;
        int id_crafting_item;

        public items_recipes_handler(int id_craftable, int id_crafting_item)
        {
            this.id_craftable = id_craftable;
            this.id_crafting_item = id_crafting_item;
        }

        public items_recipes_handler() { }
    }
}
