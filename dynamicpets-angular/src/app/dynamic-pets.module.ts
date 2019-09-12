
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as DynamicPets from './components/dynamic-pets';

@NgModule({
  imports: [
    CommonModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    DynamicPets.Form1Component,
    DynamicPets.UserControl1Component,
    DynamicPets.UserControl3Component,
    DynamicPets.UserControl2Component,
  ],
  declarations: [
    DynamicPets.Form1Component,
    DynamicPets.UserControl1Component,
    DynamicPets.UserControl3Component,
    DynamicPets.UserControl2Component,
  ],
  entryComponents: [
    DynamicPets.Form1Component,
    DynamicPets.UserControl1Component,
    DynamicPets.UserControl3Component,
    DynamicPets.UserControl2Component,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class DynamicPetsModule { }

