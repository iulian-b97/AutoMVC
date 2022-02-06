import { Component } from "@angular/core";
import { FormBuilder} from "@angular/forms";
import { AnnouncementService } from "src/app/_announcement-management/announcement.service";
import { Announcement } from "../../announcement";
import { Car } from "../car";

@Component({
    selector: 'add-car',
    templateUrl: './add-car-announcement.component.html',
    styleUrls: ['./add-car-announcement.component.css']
})
export class AddCarAnnouncementComponent {
    constructor(private announcementService: AnnouncementService, private fb: FormBuilder) { }

    announcementForm = this.fb.group({
        announcement: this.fb.group(new Announcement()),
        car: this.fb.group(new Car())    
    });

    createAnnouncement() {
        this.announcementService.createCarAnnouncement(this.announcementForm)
            .subscribe(() => {
                console.log(this.announcementForm.value)
                this.announcementForm.reset()
            })
    }
}