import { Component } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    templateUrl: './add-announcement.component.html',
    styleUrls: ['./add-announcement.component.css']
})
export class AddAnnouncementComponent {
    constructor(private router:Router) {
        
    }

    selected: string = 'Car';

    //event handler for the select element's change event
    selectChangeHandler (event: any) {
        //update the ui
        this.selected = event.target.value;
    }
}