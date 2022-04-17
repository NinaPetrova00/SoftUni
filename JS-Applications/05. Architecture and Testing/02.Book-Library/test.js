const { chromium } = require('playwright-chromium');
const { expect } = require('chai');
const { isTypedArray } = require('util/types');

describe('Tests', async function() {
    this.timeout(6000);

    let browser, page;

    before(async() => {
        browser = await chromium.launch({ headless: false, slowMo: 100 });
    });

    after(async() => {
        await browser.close();
    });

    beforeEach(async() => {
        page = await browser.newPage();
    });

    afterEach(async() => {
        page.close();
    });


    it('loads all books', async() => {
        // navigate to page

        await page.goto('http://localhost:5500');
        await page.screenshot({ path: 'page.png' });

        // find and click load button
        await page.click('text=LOAD ALL BOOKS');

        // check that books are displayed
        await page.waitForSelector('text=Harry Potter');

        const rowData = await page.$$eval('tbody tr', rows => rows.map(r => r.textContent));
        console.log(rowData);
    });
});