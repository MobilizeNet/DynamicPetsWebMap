import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "dynamic-pets-user-control1",
   styleUrls : ["./user-control1.component.css"],
   templateUrl : "./user-control1.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["DynamicPets.UserControl1"])
export class UserControl1Component extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}