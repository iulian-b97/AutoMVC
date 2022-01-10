import { Component } from "@angular/core";

@Component({
    templateUrl: './view-trailer-announcement.component.html',
    styleUrls: ['./view-trailer-announcement.component.css']
})
export class ViewTrailerAnnouncementComponent {
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