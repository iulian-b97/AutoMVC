import { Component } from "@angular/core";

@Component({
    templateUrl: './view-truck-announcement.component.html',
    styleUrls: ['./view-truck-announcement.component.css']
})
export class ViewTruckAnnouncementComponent {
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