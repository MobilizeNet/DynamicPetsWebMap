import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "dynamic-pets-user-control2",
   styleUrls : ["./user-control2.component.css"],
   templateUrl : "./user-control2.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["DynamicPets.UserControl2"])
export class UserControl2Component extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}