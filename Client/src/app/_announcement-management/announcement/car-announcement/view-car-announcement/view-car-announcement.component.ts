import { Component } from "@angular/core";

@Component({
    templateUrl: './view-car-announcement.component.html',
    styleUrls: ['./view-car-announcement.component.css']
})
export class ViewCarAnnouncementComponent {
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