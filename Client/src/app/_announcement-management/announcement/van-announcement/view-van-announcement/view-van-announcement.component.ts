import { Component } from "@angular/core";

@Component({
    templateUrl: './view-van-announcement.component.html',
    styleUrls: ['./view-van-announcement.component.css']
})
export class ViewVanAnnouncementComponent {
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