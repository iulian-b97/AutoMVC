import { Component } from "@angular/core";
import { FormBuilder } from "@angular/forms";
import { AnnouncementService } from "src/app/_announcement-management/announcement.service";
import { Announcement } from "../../announcement";
import { Motorcycle } from "../motorcycle";

@Component({
    selector: 'add-motorcycle',
    templateUrl: './add-motorcycle-announcement.component.html',
    styleUrls: ['./add-motorcycle-announcement.component.css']
})
export class AddMotorcycleAnnouncementComponent {
    constructor(private announcementService: AnnouncementService, private fb: FormBuilder) { }

    announcementForm = this.fb.group({
        announcement: this.fb.group(new Announcement()),
        motorcycle: this.fb.group(new Motorcycle())    
    });

    createAnnouncement() {
        this.announcementService.createMotorcycleAnnouncement(this.announcementForm)
            .subscribe(() => {
                console.log(this.announcementForm.value)
                this.announcementForm.reset()
            })
    }
}