import { Component } from "@angular/core";

@Component({
    templateUrl: './view-motorcycle-announcement.component.html',
    styleUrls: ['./view-motorcycle-announcement.component.css']
})
export class ViewMororcycleAnnouncementComponent {
    index: number = 1

    decIndex() {
        if(this.index > 1)
            this.index--
    }

    incIndex() {
        if(this.index < 5)
            this.index++
    }
}