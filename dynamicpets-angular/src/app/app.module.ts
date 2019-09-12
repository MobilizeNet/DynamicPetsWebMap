import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NgZone, ChangeDetectorRef} from '@angular/core';
import { AppComponent } from './app.component';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';
import { DynamicPetsModule } from './dynamic-pets.module';
@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    WebMapKendoModule,
    WebMapModule,
    DynamicPetsModule,
  ],
  providers: [WebMapService  ],
  bootstrap: [AppComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }

