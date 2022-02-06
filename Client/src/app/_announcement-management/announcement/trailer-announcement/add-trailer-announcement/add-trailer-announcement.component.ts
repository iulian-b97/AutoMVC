import { Component } from "@angular/core";
import { FormBuilder } from "@angular/forms";
import { AnnouncementService } from "src/app/_announcement-management/announcement.service";
import { Announcement } from "../../announcement";
import { Trailer } from "./trailer";

@Component({
    selector: 'add-trailer',
    templateUrl: './add-trailer-announcement.component.html',
    styleUrls: ['./add-trailer-announcement.component.css']
})
export class AddTrailerAnnouncementComponent {
    constructor(private announcementService: AnnouncementService, private fb: FormBuilder) { }

    announcementForm = this.fb.group({
        announcement: this.fb.group(new Announcement()),
        trailer: this.fb.group(new Trailer())    
    });

    createAnnouncement() {
        this.announcementService.createTrailerAnnouncement(this.announcementForm)
            .subscribe(() => {
                console.log(this.announcementForm.value)
                this.announcementForm.reset()
            })
    }
}