import { Component } from "@angular/core";
import { FormBuilder } from "@angular/forms";
import { AnnouncementService } from "src/app/_announcement-management/announcement.service";
import { Announcement } from "../../announcement";
import { Van } from "../van";

@Component({
    selector: 'add-van',
    templateUrl: './add-van-announcement.component.html',
    styleUrls: ['./add-van-announcement.component.css']
})
export class AddVanAnnouncementComponent {
    constructor(private announcementService: AnnouncementService, private fb: FormBuilder) { }

    announcementForm = this.fb.group({
        announcement: this.fb.group(new Announcement()),
        van: this.fb.group(new Van())    
    });

    createAnnouncement() {
        this.announcementService.createVanAnnouncement(this.announcementForm)
            .subscribe(() => {
                console.log(this.announcementForm.value)
                this.announcementForm.reset()
            })
    }
}